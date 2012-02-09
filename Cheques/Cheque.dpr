program Cheque;

uses
  Forms,
  UCheque in 'UCheque.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.Run;
end.
