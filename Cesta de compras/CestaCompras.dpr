program CestaCompras;

uses
  Forms,
  ClsCestaCompras in 'src\ClsCestaCompras.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.Run;
end.
