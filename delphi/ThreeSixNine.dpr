program ThreeSixNine;

{$APPTYPE CONSOLE}

uses
  SysUtils;

var
  i, j, NumClap: Integer;

function GetNumClap(AValue: Integer): Integer;
var
  order: Integer;
  source, target: String;
begin
  Result := 0;
  source := IntToStr(AValue);
  order := length(source);
  target := copy(source,order,1);

  while order > 0 do
  begin
    if (target = '3') or (target = '6') or (target = '9') then Result := Result + 1;
    order := order - 1;
    target := copy(source,order,1);
  end;

end;

{Main}
begin
  for i := 1 to 100 do
  begin
    NumClap := GetNumClap(i);

    if NumClap <> 0 then
    begin
      for j := 1 to NumClap do Write(' clap');
      Write('(',i,')');
    end
    else
      Write(' ',i,' ');

  end;

  ReadLn;
end.
