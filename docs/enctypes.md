![img](https://i.imgur.com/F2fxgOn.png)

**A group of classes and structures for storing values while efficiently keeping them encrypted in the memory.**  
**In memory, they are saved as a "weird" array of bytes that is affected by random values (encryption keys).**  
**You can find all the EncTypes in [this](https://github.com/JosepeDev/VarEnc/tree/main/EncTypes) folder. You can also use the** 
**[benchmark](https://github.com/JosepeDev/VarEnc/tree/main/Benchmark) executable file, to speed test each type.**  

Let's say you want to create a variable for a score inside a video game.  
With a simple program like CheatEngine and many more, anyone can edit the value of this variable.  
This is when you want to use an EncType. Each type does not depend on the other, so you can copy only the types you need.  

## Which type to use?

- **EncInt** - For storing an int. Every time you change its value, the random encryption keys that affect its value change too.
- **EncLong** - The same thing as the struct above, but for a 64-bit integer (a long).
- **EncFloat** - The same thing as the struct above, but for a Single (float).
- **EncDouble** - The same thing as the struct above, but for a Double.
- **EncDecimal** - The same thing as the struct above, but for a Decimal.
- **EncString** - An EncType class for a string type.

You can find the EncTypes folder [here](https://github.com/JosepeDev/VarEnc/tree/main/EncTypes)

## Examples

#### Creating and assigning

```csharp
int normalInt = 11;
EncInt encryptedInt = 11;

// Works the same with these

double normalDouble = 8.109901;
EncDouble encryptedDouble = 8.109901;

// Works the same with these

string normalString = "That's a text";
EncString encryptedString = "That's a text";
```

#### Math

```csharp

// An int example, but works the same with doubles.
int normalInt = 0;
EncInt encryptedInt = 0;
normalInt += 18;
encryptedInt += 18; 
normalInt /= 9;
encryptedInt /= 9; 

// Strings
string normalString = "That's a text";
EncString encryptedString = "That's a text";
normalString += "more text";
encryptedString += "more text";

```

**They will work the same as their normal type.**  
**Even with Incrementing/Decrementing/Multiplying/Dividing/Comparing.**  
**But in the background it is encrypted.**  
**Without you worrying about encryption or decryption, you work with your variables just the same.**  
**You can also combine and/or compare an EncType with its normal type and vice versa.**  
**Every EncType has every method its normal version has.**

## Documentations

**Every EncType contains the same methods and fields as its normal type.**  
**So it'll link you to the official .NET documentaions.**
### CSharp
- [EncInt](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=net-5.0)
- [EncLong](https://docs.microsoft.com/en-us/dotnet/api/system.int64?view=net-5.0)
- [EncFloat](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=net-5.0)
- [EncDouble](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-5.0)
- [EncDecimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal?view=net-5.0)
- [EncString](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-5.0)


**Return back to the root folder**