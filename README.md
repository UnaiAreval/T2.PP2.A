# T2.PP2.A

## Exercici 1
```C#
public static int RecMethod(int num)
{
	int total = 0;

	if (num < 10) return num;

	while (num > 0)
	{
    	    total += num % 10;
    	    num /= 10;
	}

	return RecMethod(total);
}
```

## Exercici 4
CMP -> 00 MOV-> 01 ADD -> 10  BEQ -> 11
### A
CMP 3F, 45
CMP 63, 69 -> DECIMAL
00 111111 1000101
### B
MOV AE, 94
MOV 174, 148 -> DECIAML
01 10101110 100010100
### C
ADD 11, A3
ADD 17, 163 -> DECIAML
10 10001 10100011
### D
MOV 8A, 77
MOV 138, 112 -> DECIAML
01 10001010 1110000