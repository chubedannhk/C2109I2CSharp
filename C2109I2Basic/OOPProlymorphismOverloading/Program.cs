
using OOPProlymorphismOverloading;

// object initializer
BasicMath basic = new();
BasicMath basic2 = new()
{
    NumberOne= 1,
};
BasicMath basic3 = new()
{
    NumberTwo = 12,
};
BasicMath basic4 = new()
{
    NumberTwo = 12,
    NumberOne= 1,
};

basic.Sum();
basic.Sum(1,2);
basic.Sum(1);
//named argumemt
basic.Sum(num2: 5);
basic.Sum(num2: 5,num1:4);