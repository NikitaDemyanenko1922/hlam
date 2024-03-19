function t=Test2(x)
a=1;
k=0;
if abs(x)<=a
    k = cos(pi*x/(2*a));
else
    k = 0;
end
t = k;
end