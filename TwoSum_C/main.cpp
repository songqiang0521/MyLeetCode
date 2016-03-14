/**
* Note: The returned array must be malloced, assume caller calls free().
*/

#include <stdio.h>
#include <memory.h>
#include <cstdlib>

typedef struct _Pair
{
    int value;
    int index;
}Pair;

int cmp(const void* a, const void* b)
{
    return ((Pair*)a)->value - ((Pair*)b)->value;
}

int* TwoSum(int* nums, int numsSize, int target)
{
    int size = sizeof(Pair)*numsSize;
    Pair* pairs = (Pair*)malloc(size);
    memset(pairs, 0, size);

    int i = 0;
    int j = 0;

    for (i = 0; i < numsSize; i++)
    {
        pairs[i].value = nums[i];
        pairs[i].index = i;
    }

    qsort(pairs, numsSize, sizeof(Pair), cmp);
    int* ret = (int*)malloc(8);
    ret[0] = 0;
    ret[1] = 0;

    i = 0;
    j = numsSize - 1;
    while (i<j)
    {
        int sum = pairs[i].value + pairs[j].value;
        if (sum<target)
        {
            i++;
        }
        else if (sum >target)
        {
            j--;
        }
        else
        {
            int index1 = pairs[i].index;
            int index2 = pairs[j].index;
            ret[0] = index1>index2 ? index2 : index1;
            ret[1] = index1 > index2 ? index1 : index2;
            return ret;
        }
    }
    return ret;
}


int main()
{
    int numbers[12] = { 1,2,3,4,5,6,7 };
    int* result = TwoSum(numbers, 7, 13);
}
