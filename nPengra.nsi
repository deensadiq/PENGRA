;Opal Academy  Installer
;
;Written by D.M Wulgo
;Cerebro Systems
;info@cerebrosystems.com

;--------------------------------------------------
; INITIALIZE
;

!define oProduct "Pension Databank"                    ; products Name
!define oVersion " Version 1.0"                    ; product version
!define oExecutable "PENGRA"                         ; name of the product executable
;!define oPackage "Run"                        ; place where all dependency file are kept
!define oPackage "Run"                        ; place where all dependency file are kept

!define oInstaller "Graphics\Installer"
!define oIcon "ICON-32x32.ico"
!define oUnIcon "uninstallICON-32x32.ico"
!define oIconMUI "ICON-48x48.ico"
!define oUnIconMUI "uninstallICON-48x48.ico"

!define oInTopBmpMUI "installer-top.bmp"
!define oUnInTopBmpMUI "installer-top.bmp"
!define oInSideBmpMUI "installer-side.bmp"
!define oUnInSideBmpMUI "installer-side.bmp"


!define oBranding "Copyright © 2015 Cerebro Systems"
!define oBrandingLink "http://www.cerebrosystems.com"

!define WNDCLASS "PENGRA"
!define WNDTITLE "Pension Databank"
!define SplashImage "splash.gif"


;--------------------------------
;Include Modern UI

  !include "MUI.nsh"
  !include "WordFunc.nsh"
  !insertmacro "VersionCompare"
  !include "LogicLib.nsh"
  !include "WinMessages.nsh"
  !include "Sections.nsh"

;--------------------------------
;
;General


  XpStyle on

  Name "${oProduct}${oVersion}"
  OutFile "${oProduct}_${oVersion}_Setup.exe"
  Icon  "${oInstaller}\${oIcon}"
  UninstallIcon "${oInstaller}\${oUnIcon}"
  BrandingText "${oBranding}"
  SetOverwrite on
  InstallDir "$PROGRAMFILES\${oProduct}${oVersion}"    ;Default installation folder
  InstallDirRegKey HKCU "Software\${oProduct}${oVersion}" ""   ;Get installation folder from registry if available



;-----------------------------------------
;
;                FUNCTIONS
;
;----------------------------------------

Function un.onInit
  FindWindow $0 "${WNDCLASS}" "${WNDTITLE}"
  StrCmp $0 0 continueInstall
    MessageBox MB_ICONSTOP|MB_OK "The ${oProduct}${oVersion} you are trying to remove is running. Close it and try again."
    Abort
  continueInstall:
FunctionEnd

Function GetDotNETVersion
  Push $0
  Push $1

  System::Call "mscoree::GetCORVersion(w .r0, i ${NSIS_MAX_STRLEN}, *i) i .r1 ?u"
  StrCmp $1 "error" 0 +2
    StrCpy $0 "not found"
 
  Pop $1
  Exch $0
FunctionEnd





Function onGUIInit
 ;--------------------------------------------------------
         ; Display Splash Screen

        InitPluginsDir

        SetOutPath "$PLUGINSDIR"
        File  "${SplashImage}"

        newadvsplash::show  600 1000 2000 0x00FF00  "$PLUGINSDIR\${SplashImage}"
        newadvsplash::stop /fadeout
        Delete "$PLUGINSDIR\${SplashImage}"
        SetOutPath "$EXEDIR"

        ;----------------------------------------------------------------

        BrandingURL::Set /NOUNLOAD "200" "0" "0" "${oBrandingLink}"   ; Set the hyperlink up.



FunctionEnd

; Unload the plugin.
Function un.onGUIEnd

 BrandingURL::Unload

FunctionEnd



Function .onInit

       ; Check for DotNet Framework
       ;
        Call GetDotNETVersion
        Pop $0
        ${If} $0 == "not found"
          MessageBox MB_OK|MB_ICONSTOP ".NET runtime library is not installed."
          Abort
        ${EndIf}
       
        StrCpy $0 $0 "" 1 # skip "v"
       
        ${VersionCompare} $0 "1.1" $1
        ${If} $1 == 2
          MessageBox MB_OK|MB_ICONSTOP ".NET runtime library v1.1 or newer is required. You have $0."
          Abort
        ${EndIf}

        ;-----------------------------------------
        ;   Dialog Box

        MessageBox MB_YESNO "This will install ${oProduct}${oVersion} on your Computer. Do you wish to continue?"  IDYES chigaba
        Abort

        chigaba:

        


FunctionEnd

;Variables

  Var MUI_TEMP
  Var STARTMENU_FOLDER
;--------------------------------
;Interface Settings

  !define MUI_CUSTOMFUNCTION_GUIINIT onGUIInit

  !define MUI_ICON  "${oInstaller}\${oIconMUI}"
  !define MUI_UNICON  "${oInstaller}\${oUnIconMUI}"
  !define MUI_HEADERIMAGE
  !define MUI_HEADERIMAGE_BITMAP "${oInstaller}\${oInTopBmpMUI}"
  !define MUI_HEADERIMAGE_UNBITMAP "${oInstaller}\${oUnInTopBmpMUI}"
  !define MUI_WELCOMEFINISHPAGE_BITMAP "${oInstaller}\${oInSideBmpMUI}"
  !define MUI_UNWELCOMEFINISHPAGE_BITMAP "${oInstaller}\${oUnInSideBmpMUI}"
  !define MUI_ABORTWARNING

;--------------------------------
;Pages

  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY

 ;Start Menu Folder Page Configuration
  !define MUI_STARTMENUPAGE_REGISTRY_ROOT "HKCU" 
  !define MUI_STARTMENUPAGE_REGISTRY_KEY "Software\${oProduct}${oVersion}"
  !define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "Start Menu Folder"
  
  !insertmacro MUI_PAGE_STARTMENU Application $STARTMENU_FOLDER
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH

  !insertmacro MUI_UNPAGE_WELCOME
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  !insertmacro MUI_UNPAGE_FINISH

;--------------------------------
;Languages

  !insertmacro MUI_LANGUAGE "English"

;---------------------------------
; SECTIONS
;

Section "${oProduct}${oVersion}" Core

  SetOutPath "$INSTDIR"

  ;Dependency

  File "${oPackage}\*.*"

  ;check for firebird installation in the registry
  ;if the registry key doesn't exist and error is raised and we jump to INST
  ;where firebird will be installed. If it exists we jump to CONT skipping
  ;the line calling the installer.

  ClearErrors
  ReadRegStr $0 HKLM "SOFTWARE\Firebird Project\Firebird Server\Instances" "DefaultInstance"
  IfErrors 0 +2
	goto INST
  goto CONT

  INST:
	ExecWait '"Firebird-2.5.exe" /VERYSILENT'
	
  CONT:
	Delete Firebird-2.5.exe
	
  ExecWait '"WriteAlias.exe" "PENGRA" "$INSTDIR\PENGRAREPORT.DLL"'



  WriteRegStr HKCU "Software\${oProduct}${oVersion}" "" $INSTDIR         ;Store installation folder

  WriteUninstaller "$INSTDIR\Uninstall.exe"                  ;Create uninstaller

  !insertmacro MUI_STARTMENU_WRITE_BEGIN Application

    ;Create shortcuts
    CreateDirectory "$SMPROGRAMS\$STARTMENU_FOLDER"
    CreateShortCut "$SMPROGRAMS\$STARTMENU_FOLDER\${oExecutable}.lnk" "$INSTDIR\${oExecutable}.exe"
    CreateShortCut "$SMPROGRAMS\$STARTMENU_FOLDER\Uninstall.lnk" "$INSTDIR\Uninstall.exe"

  !insertmacro MUI_STARTMENU_WRITE_END
SectionEnd

LangString DESC_Section1 ${LANG_ENGLISH} "${oProduct}${oVersion}"


!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${Core} $(DESC_Section1)
!insertmacro MUI_FUNCTION_DESCRIPTION_END



;Uninstaller Section

Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...

  Delete "$SMPROGRAMS\${oProduct}${oVersion}"
  Delete "$INSTDIR\*.*"
  Delete "$INSTDIR\Uninstall.exe"

  RMDir "$INSTDIR"

!insertmacro MUI_STARTMENU_GETFOLDER Application $MUI_TEMP

  Delete "$SMPROGRAMS\$MUI_TEMP\Uninstall.lnk"
  Delete "$SMPROGRAMS\$MUI_TEMP\${oExecutable}.lnk"

  ;Delete empty start menu parent diretories
  StrCpy $MUI_TEMP "$SMPROGRAMS\$MUI_TEMP"

  startMenuDeleteLoop:
	ClearErrors
    RMDir $MUI_TEMP
    GetFullPathName $MUI_TEMP "$MUI_TEMP\.."

    IfErrors startMenuDeleteLoopDone

    StrCmp $MUI_TEMP $SMPROGRAMS startMenuDeleteLoopDone startMenuDeleteLoop
  startMenuDeleteLoopDone:

  DeleteRegKey /ifempty HKCU "Software\${oProduct}${oVersion}"

SectionEnd






