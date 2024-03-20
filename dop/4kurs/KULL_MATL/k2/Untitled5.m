function rt=Untitled5(x)
n = [];
m = [];
b = 64;
for i=0:20
    x1=sqrt(b-(pi/2+pi*i)^2);
    if isreal(x1)
        n=[n,x1];
    else 
        m=[m,x1];
    end
end

t1= min(n)/2;
t2 = max(n)+1;
dt = 0.015;
a = 1;

s = 0;
if x>=a
    for i=1:length(n)
        s = s+Kres(-n(i)).*Fun(a,-n(i)).*exp(1i.*n(i)*x);
    end
    rt = 1i.*(-s);
else
    for i=1:length(n)
        s = s+Kres(n(i)).*Fun(a,n(i)).*exp(-1i.*n(i)*x);
    end
    rt = 1i.*s;
end

end