#include "grains.h" 

uint64_t square(uint8_t index)
{
    uint64_t temp = 1;

    if(index == 1)
        return 1;
    else if(index == 0)
        return 0;
    
    for(int i = 1; i < index; i++)
    {
        temp *= 2;
    }

    return temp;
}

uint64_t total(void)
{
    uint64_t sum = 0;
    uint64_t temp = 1;
    
    for(int i = 1; i < 64; i++)
    {
        temp *= 2;
        sum += temp;
    }

    return sum + 1;
}