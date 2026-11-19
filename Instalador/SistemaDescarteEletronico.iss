; Instalador do Sistema de Descarte de E-lixo (Inno Setup 6.3 ou superior)
; Antes de compilar este script, gere a aplicação em modo Release no Visual Studio:
; os arquivos são lidos de ..\SistemaDescarteEletronico\bin\Release

#define NomeApp "Sistema de Descarte de E-lixo"
#define VersaoApp "1.0.0"
#define Executavel "SistemaDescarteEletronico.exe"

[Setup]
AppId={{8D2F4B6A-1C3E-4A5F-9B7D-6E0C2A4F8D13}
AppName={#NomeApp}
AppVersion={#VersaoApp}
AppVerName={#NomeApp} {#VersaoApp}
AppPublisher=Equipe 10 - Ciência da Computação - UNISAGRADO
VersionInfoVersion=1.0.0.0
DefaultDirName={autopf}\SistemaDescarteEletronico
DisableDirPage=no
DisableProgramGroupPage=yes
OutputDir=Saida
OutputBaseFilename=Instalador_SistemaDescarteEletronico_{#VersaoApp}
SetupIconFile=icone.ico
UninstallDisplayIcon={app}\{#Executavel}
UninstallDisplayName={#NomeApp}
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
MinVersion=10.0
; se o programa estiver aberto, o instalador e o desinstalador pedem pra fechar antes
AppMutex=SistemaDescarteEletronico_Equipe10

[Languages]
Name: "ptbr"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "atalhodesktop"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
; copia tudo o que está em bin\Release, menos arquivos de depuração
Source: "..\SistemaDescarteEletronico\bin\Release\*"; DestDir: "{app}"; Excludes: "*.pdb,*.vshost.*"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{autoprograms}\{#NomeApp}"; Filename: "{app}\{#Executavel}"
Name: "{autodesktop}\{#NomeApp}"; Filename: "{app}\{#Executavel}"; Tasks: atalhodesktop

[Run]
Filename: "{app}\{#Executavel}"; Description: "{cm:LaunchProgram,{#NomeApp}}"; Flags: nowait postinstall skipifsilent

; Os dados do usuário ficam em %AppData%\SistemaDescarteEletronico e não são
; apagados na desinstalação (não há seção [UninstallDelete] de propósito).

[Code]
// o .NET Framework 4.8.1 grava o valor "Release" igual ou maior que 533320 no registro
function DotNet481Instalado(): Boolean;
var
  Versao: Cardinal;
begin
  Result := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', Versao)
            and (Versao >= 533320);
end;

function InitializeSetup(): Boolean;
begin
  Result := True;
  if not DotNet481Instalado() then
  begin
    Result := MsgBox('Este programa precisa do .NET Framework 4.8.1, que não foi encontrado neste computador.' + #13#10 + #13#10 +
                     'Ele pode ser baixado gratuitamente no site da Microsoft:' + #13#10 +
                     'https://dotnet.microsoft.com/pt-br/download/dotnet-framework/net481' + #13#10 + #13#10 +
                     'Deseja continuar a instalação mesmo assim?', mbConfirmation, MB_YESNO) = IDYES;
  end;
end;
