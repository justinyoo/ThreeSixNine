<%
for i = 1 to 100
	if i > 1 then response.write ", "
	if ( i mod 3 ) then
		response.write i
	else
		response.write """clap"" ("& i &")"
	end if
next
%>