function tt=TestMy(x)
a=1;
gr = 10;
fun = @(alfa)((1i/2)*(2*a*(2*a*alfa-pi).*sin(a*alfa)-2*a*(2*a*alfa+pi).*sin(a*alfa)+8*a*a*alfa)/(2*a));
tt = integral(fun,0,gr);
end