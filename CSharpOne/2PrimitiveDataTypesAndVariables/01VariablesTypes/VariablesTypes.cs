// 01. Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

// sbyte    [-128 to +128]
// byte     [0 to 255]
// short    [-32768 to +32767]
// ushort   [0 to 65535]
// int      [-2147483648 to +2147483647]
// uint     [0 to 4294967295]
// long     [-9223372036854775808 to 9223372036854775807]
// ulong    [0 to 18446744073709551615]

using System;

class VariablesTypes
{
    static void Main()
    {
        byte var1 = 97;
        sbyte var2 = -115;
        short var3 = -10000;
        ushort var4 = 52130;
        int var5 = 4825932;

        Console.WriteLine("Print the variables: {0} {1} {2} {3} {4}", var1, var2, var3, var4, var5);
    }
}