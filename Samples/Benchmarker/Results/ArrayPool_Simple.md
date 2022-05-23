|                                     Method | Count | ArraySize |     Mean |   Error |  StdDev | Ratio |    Gen 0 |   Allocated |
|------------------------------------------- |------ |---------- |---------:|--------:|--------:|------:|---------:|------------:|
|                        CreateAndFillArrays |  1000 |      1024 | 568.7 us | 3.06 us | 2.71 us |  1.00 | 500.9766 | 1,048,001 B |
|                    UsePooledArrayAndFillIt |  1000 |      1024 | 541.3 us | 1.15 us | 1.02 us |  0.95 |        - |         1 B |
| UsePooledArrayAndFillItWithMultipleThreads |  1000 |      1024 | 152.1 us | 2.49 us | 2.08 us |  0.27 |        - |           - |
