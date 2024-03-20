function funk=Kres(al)
z=-0.5;
b = 64;
funk =(sinh(sqrt(al.^2-b).*(z+1))/(al.*sinh(sqrt(al.^2-b))));
end