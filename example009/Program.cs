int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//               0  1  2  3  4  5  6  7  8
int [] array = {15,23,31,44,53,66,27,18,99};



int result = Max(
    Max(array[0], array [1], array[2]),
    Max(array[3], array [4], array[5]),
    Max(array[0], array [1], array[2])
);
Console.WriteLine(result);
