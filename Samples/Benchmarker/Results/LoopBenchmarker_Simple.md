# 1000 ducks say more than an image

Loop over 1000 ducks.

|          Method |       Mean |    Error |   StdDev |    Ratio |  Gen 0 | Allocated |
|---------------- |-----------:|---------:|---------:|---------:|-------:|----------:|
|         LinqSum | 7,603.7 ns | 18.02 ns | 14.07 ns |     1.00 | 0.0153 |      40 B |
| IEnumerableLoop | 7,577.8 ns | 15.78 ns | 13.99 ns |     1.00 | 0.0153 |      40 B |
|     ForEachLoop |   952.7 ns |  2.38 ns |  1.99 ns |     0.13 |      - |         - |
|         ForLoop |   715.0 ns |  1.97 ns |  1.75 ns | **0.09** |      - |         - |

