program CestaComprasTest;

{$IFDEF CONSOLE_TESTRUNNER}
{$APPTYPE CONSOLE}
{$ENDIF}

uses
  Forms,
  TestFramework,
  GUITestRunner,
  TextTestRunner,
  ClsCestaComprasTest in 'src\ClsCestaComprasTest.pas',
  ClsCestaCompras in 'src\ClsCestaCompras.pas';

{$R *.RES}

begin
  Application.Initialize;

  if IsConsole then begin
    TextTestRunner.RunRegisteredTests
  end else begin
    GUITestRunner.RunRegisteredTests;
  end;
end.

