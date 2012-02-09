program FizzBuzz;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  UntFizzBuzz in 'UntFizzBuzz.pas';

begin
  try
    { TODO -oUser -cConsole Main : Insert code here }
  except
    on E:Exception do
      Writeln(E.Classname, ': ', E.Message);
  end;
end.
