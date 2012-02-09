unit UntFizzBuzz;

interface

type
  TFizzBuzz = class
    class function ToString(n: Integer): string;
  end;

implementation

uses
  SysUtils;
{ TFizzBuzz }

class function TFizzBuzz.ToString(n: Integer): string;
begin
  if ((n mod 15) = 0) then
  begin
    Result := 'Fizz Buzz';
  end
  else if (n mod 5) = 0 then
  begin
    Result := 'Buzz';
  end
  else begin
  if (n mod 3) = 0 then
  begin
    Result := 'Fizz';
  end
  else begin
    Result := IntToStr(n);
  end;
  end;

end;

end.
