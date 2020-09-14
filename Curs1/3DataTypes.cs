using System;

namespace Curs1
{
    class DataTypes
    {
        // C# keywords: base, bool, break, case, interface, out, in, if, return, while, void, sealed
        // Data types:

        // Boolean value: True or False, Default: False
        bool isDay = true;
        bool isNight = false;

        // 8-bit unsigned integer:  0 to 255, Default: 0
        byte shape = 0xFF; 
        byte shape2 = 255;

        // 16-bit Unicode character: U +0000 to U +ffff
        char letter_X = 'X';        // Character literal
        char letter_X2 = '\x0058';  // Hexadecimal
        char letter_X3 = (char)88;  // Cast from integral type
        char letter_X4 = '\u0058';  // Unicode
        // Output: X X X X


        // double: 64-bit double-precision floating point type, Default: 0.0D
        double width = 2.5;

        // float: 32-bit single-precision floating point type, Default: 0.0F
        float y = 3.5f;

        // int: 32-bit signed integer type, Default: 0 
        int x = 10;

        //Reference Types:

        // Object Type: can be assigned values of any other types
        // type checking for object type variables takes place at compile time
        object exampleObj = 40;
        // Boxing: value type converted to object type
        // Un-boxing: object type converted to value type 

        // Dynamic Type: Type checking for these types of variables takes place at run-time
        dynamic exampleDynamic = 50;

        //String Type
        String stringExample = "C# Workshop!";
    }
}
