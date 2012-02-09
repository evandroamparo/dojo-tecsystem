unit UTesteCheque;
{

  Delphi DUnit Test Case
  ----------------------
  This unit contains a skeleton test case class generated by the Test Case Wizard.
  Modify the generated code to correctly setup and call the methods from the unit 
  being tested.

}

interface

uses
  TestFramework, UCheque;

type
  // Test methods for class Cheque

  TestCheque = class(TTestCase)
  strict private
    FCheque: Cheque;
  private

  public
    procedure SetUp; override;
    procedure TearDown; override;
  published
    procedure TesteUmReal;
    procedure TesteUmRealEDezCentavos;
    procedure TesteCinquentaReais;
  end;

implementation

procedure TestCheque.SetUp;
begin
  FCheque := Cheque.Create;
end;

procedure TestCheque.TearDown;
begin
  FCheque.Free;
  FCheque := nil;
end;

procedure TestCheque.TesteUmReal;
var
  ReturnValue: string;
  Valor: Real;
begin
  Valor := 1;
  ReturnValue := FCheque.ImprimeValor(Valor);
  CheckEquals('UM REAL', ReturnValue);
end;

procedure TestCheque.TesteUmRealEDezCentavos;
var
  ReturnValue: string;
  Valor: Real;
begin
  Valor := 1.1;
  ReturnValue := FCheque.ImprimeValor(Valor);
  CheckEquals('UM REAL E DEZ CENTAVOS', ReturnValue);
end;

procedure TestCheque.TesteCinquentaReais;
var
  ReturnValue: string;
  Valor: Real;
begin
  Valor := 50;
  ReturnValue := FCheque.ImprimeValor(Valor);
  CheckEquals('CINQUENTA REAIS', ReturnValue);
end;

initialization
  // Register any test cases with the test runner
  RegisterTest(TestCheque.Suite);
end.
