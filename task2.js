let x=1,y=2,z=3;
if(x<y && x<z)
{
    console.log("X is the minimum number");
}
else if(y<z && y<x)
{
    console.log("Y is the minimum number");
}
else if(z<y && z<x)
{
    console.log("Z is the minimum number");
}
else if(x==y==z)
{
    console.log("All the numbers are the same");
}
