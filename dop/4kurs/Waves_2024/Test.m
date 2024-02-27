x = linspace(-5, 5, 50);
y(1:length(x))=0;
for i=1:length(x)
    y(i) = TestMy(x(i));
end
plot(x,abs(y));
%clc
