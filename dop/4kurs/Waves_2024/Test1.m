function tt=Test1(x)
a=1;
gr = 10;
fun = @(alfa)(4.*sin(alfa.*a).*cos(alfa.*x))./(alfa.*pi.*2);
tt = integral(fun,0,gr);
end