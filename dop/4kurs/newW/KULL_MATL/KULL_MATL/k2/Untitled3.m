function tt=Untitled3(x1)
n = [];
m = [];
b = 16;
for i=0:20
    x=sqrt(b-(pi/2+pi*i)^2);
    if isreal(x)
        n=[n,x];
    else 
        m=[m,x];
    end
end

gr = 1000;
t1= min(n)/2;
t2 = max(n)+1;
dt = 0.015;

tt1 = Rek(x1,0,t1);
tt2 = Rek(x1,t1,t1-1i*dt);
tt3 = Rek(x1,t1-1i*dt,t2-1i*dt);
tt4 = Rek(x1,t2-1i*dt,t2);
tt5 = Rek(x1,t2,gr);
tt = (tt1+tt2+tt3+tt4+tt5)./(2.*pi);
%disp(tt);
end
