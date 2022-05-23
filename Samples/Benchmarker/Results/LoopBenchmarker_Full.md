# A lot of combinations

Took about 40 minutes to run on a first generation M1 MacBook Pro.

.net 6.0.4, Arm64 RyuJIT

|          Method | LargeDucks | EmbeddedInJunk | DuckCount |            Mean |          Error |           StdDev |          Median | Ratio | RatioSD |  Gen 0 | Allocated |
|---------------- |----------- |--------------- |---------- |----------------:|---------------:|-----------------:|----------------:|------:|--------:|-------:|----------:|
|         LinqSum |      False |          False |       100 |       777.88 ns |       5.869 ns |         4.901 ns |       776.02 ns |  1.00 |    0.00 | 0.0191 |      40 B |
|     ForEachLoop |      False |          False |       100 |       101.08 ns |       0.329 ns |         0.291 ns |       101.07 ns |  0.13 |    0.00 |      - |         - |
|         ForLoop |      False |          False |       100 |        70.01 ns |       0.179 ns |         0.159 ns |        70.02 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |      False |          False |       100 |       791.64 ns |      15.580 ns |        13.010 ns |       791.17 ns |  1.02 |    0.02 | 0.0191 |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |      False |          False |      1000 |     7,659.83 ns |      30.490 ns |        28.520 ns |     7,663.94 ns |  1.00 |    0.00 | 0.0153 |      40 B |
|     ForEachLoop |      False |          False |      1000 |       957.08 ns |       1.718 ns |         1.434 ns |       956.80 ns |  0.12 |    0.00 |      - |         - |
|         ForLoop |      False |          False |      1000 |       719.96 ns |       6.261 ns |         5.228 ns |       717.13 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |      False |          False |      1000 |     7,807.55 ns |     151.998 ns |       134.742 ns |     7,782.09 ns |  1.02 |    0.02 | 0.0153 |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |      False |          False |     10000 |    77,569.30 ns |     695.405 ns |       616.459 ns |    77,353.01 ns |  1.00 |    0.00 |      - |      40 B |
|     ForEachLoop |      False |          False |     10000 |     9,617.58 ns |      20.296 ns |        16.948 ns |     9,624.49 ns |  0.12 |    0.00 |      - |         - |
|         ForLoop |      False |          False |     10000 |     7,276.41 ns |      97.021 ns |        90.753 ns |     7,245.72 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |      False |          False |     10000 |    76,595.84 ns |     211.770 ns |       187.729 ns |    76,584.83 ns |  0.99 |    0.01 |      - |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |      False |          False |    100000 |   772,862.65 ns |   5,838.579 ns |     5,175.748 ns |   771,019.61 ns |  1.00 |    0.00 |      - |      41 B |
|     ForEachLoop |      False |          False |    100000 |    95,720.41 ns |      59.759 ns |        46.656 ns |    95,709.82 ns |  0.12 |    0.00 |      - |         - |
|         ForLoop |      False |          False |    100000 |    72,766.38 ns |     995.384 ns |       831.191 ns |    72,352.94 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |      False |          False |    100000 |   774,508.64 ns |   5,817.757 ns |     4,542.122 ns |   775,236.90 ns |  1.00 |    0.01 |      - |      41 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |      False |           True |       100 |       787.75 ns |       5.282 ns |         4.683 ns |       786.76 ns |  1.00 |    0.00 | 0.0191 |      40 B |
|     ForEachLoop |      False |           True |       100 |       104.18 ns |       0.502 ns |         0.445 ns |       104.23 ns |  0.13 |    0.00 |      - |         - |
|         ForLoop |      False |           True |       100 |        71.56 ns |       0.654 ns |         0.580 ns |        71.46 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |      False |           True |       100 |       792.00 ns |      13.058 ns |        13.972 ns |       785.91 ns |  1.01 |    0.02 | 0.0191 |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |      False |           True |      1000 |     7,968.66 ns |      60.174 ns |        50.248 ns |     7,948.51 ns |  1.00 |    0.00 | 0.0153 |      40 B |
|     ForEachLoop |      False |           True |      1000 |       971.32 ns |       4.299 ns |         3.811 ns |       971.36 ns |  0.12 |    0.00 |      - |         - |
|         ForLoop |      False |           True |      1000 |       725.25 ns |       0.911 ns |         0.760 ns |       725.05 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |      False |           True |      1000 |     7,779.98 ns |      35.020 ns |        31.045 ns |     7,773.16 ns |  0.98 |    0.01 | 0.0153 |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |      False |           True |     10000 |   113,072.76 ns |     291.303 ns |       272.485 ns |   113,025.29 ns |  1.00 |    0.00 |      - |      40 B |
|     ForEachLoop |      False |           True |     10000 |    10,030.87 ns |      52.728 ns |        49.322 ns |    10,040.00 ns |  0.09 |    0.00 |      - |         - |
|         ForLoop |      False |           True |     10000 |     8,930.48 ns |      37.534 ns |        33.272 ns |     8,927.96 ns |  0.08 |    0.00 |      - |         - |
| IEnumerableLoop |      False |           True |     10000 |   112,587.83 ns |   2,248.392 ns |     2,589.252 ns |   111,866.20 ns |  1.00 |    0.03 |      - |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |      False |           True |    100000 | 3,534,851.98 ns | 175,950.713 ns |   513,256.487 ns | 3,423,574.79 ns |  1.00 |    0.00 |      - |      43 B |
|     ForEachLoop |      False |           True |    100000 |   369,423.81 ns |   7,328.337 ns |    19,305.770 ns |   362,939.84 ns |  0.11 |    0.02 |      - |         - |
|         ForLoop |      False |           True |    100000 |   315,155.31 ns |   6,232.073 ns |    10,412.393 ns |   310,691.44 ns |  0.09 |    0.01 |      - |         - |
| IEnumerableLoop |      False |           True |    100000 | 3,658,849.72 ns | 144,321.785 ns |   425,536.040 ns | 3,612,129.63 ns |  1.06 |    0.19 |      - |      43 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |       True |          False |       100 |       790.14 ns |       5.761 ns |         5.107 ns |       787.38 ns |  1.00 |    0.00 | 0.0191 |      40 B |
|     ForEachLoop |       True |          False |       100 |       105.66 ns |       0.759 ns |         0.673 ns |       105.78 ns |  0.13 |    0.00 |      - |         - |
|         ForLoop |       True |          False |       100 |        72.33 ns |       0.604 ns |         0.536 ns |        72.15 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |       True |          False |       100 |       782.61 ns |       5.969 ns |         5.292 ns |       780.78 ns |  0.99 |    0.01 | 0.0191 |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |       True |          False |      1000 |     7,725.72 ns |      22.220 ns |        19.697 ns |     7,719.99 ns |  1.00 |    0.00 | 0.0153 |      40 B |
|     ForEachLoop |       True |          False |      1000 |       971.08 ns |       3.388 ns |         3.003 ns |       970.49 ns |  0.13 |    0.00 |      - |         - |
|         ForLoop |       True |          False |      1000 |       728.70 ns |       2.976 ns |         2.485 ns |       728.85 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |       True |          False |      1000 |     7,730.60 ns |      43.711 ns |        38.749 ns |     7,723.81 ns |  1.00 |    0.01 | 0.0153 |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |       True |          False |     10000 |    77,373.46 ns |     194.920 ns |       162.767 ns |    77,347.28 ns |  1.00 |    0.00 |      - |      40 B |
|     ForEachLoop |       True |          False |     10000 |     9,795.98 ns |     195.374 ns |       209.048 ns |     9,720.57 ns |  0.13 |    0.00 |      - |         - |
|         ForLoop |       True |          False |     10000 |     7,375.90 ns |      25.854 ns |        21.589 ns |     7,369.06 ns |  0.10 |    0.00 |      - |         - |
| IEnumerableLoop |       True |          False |     10000 |    77,655.87 ns |     341.405 ns |       266.546 ns |    77,590.83 ns |  1.00 |    0.00 |      - |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |       True |          False |    100000 |   790,796.76 ns |  13,782.602 ns |    12,892.254 ns |   784,915.73 ns |  1.00 |    0.00 |      - |      41 B |
|     ForEachLoop |       True |          False |    100000 |    96,073.23 ns |     243.103 ns |       215.504 ns |    95,989.68 ns |  0.12 |    0.00 |      - |         - |
|         ForLoop |       True |          False |    100000 |    74,446.75 ns |   1,188.004 ns |     1,053.134 ns |    74,013.11 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |       True |          False |    100000 |   779,137.48 ns |   3,068.583 ns |     2,562.406 ns |   778,160.30 ns |  0.99 |    0.02 |      - |      41 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |       True |           True |       100 |       785.49 ns |       2.680 ns |         2.092 ns |       785.17 ns |  1.00 |    0.00 | 0.0191 |      40 B |
|     ForEachLoop |       True |           True |       100 |       103.81 ns |       0.340 ns |         0.302 ns |       103.79 ns |  0.13 |    0.00 |      - |         - |
|         ForLoop |       True |           True |       100 |        70.85 ns |       0.085 ns |         0.066 ns |        70.86 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |       True |           True |       100 |       780.75 ns |       1.486 ns |         1.241 ns |       780.94 ns |  0.99 |    0.00 | 0.0191 |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |       True |           True |      1000 |     7,933.47 ns |      32.289 ns |        26.963 ns |     7,930.57 ns |  1.00 |    0.00 | 0.0153 |      40 B |
|     ForEachLoop |       True |           True |      1000 |       967.92 ns |       2.111 ns |         1.762 ns |       968.23 ns |  0.12 |    0.00 |      - |         - |
|         ForLoop |       True |           True |      1000 |       727.58 ns |       2.665 ns |         2.363 ns |       726.88 ns |  0.09 |    0.00 |      - |         - |
| IEnumerableLoop |       True |           True |      1000 |     7,862.54 ns |      30.226 ns |        26.795 ns |     7,863.89 ns |  0.99 |    0.00 | 0.0153 |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |       True |           True |     10000 |   113,420.35 ns |     414.336 ns |       345.989 ns |   113,452.47 ns |  1.00 |    0.00 |      - |      40 B |
|     ForEachLoop |       True |           True |     10000 |    10,025.82 ns |      30.300 ns |        23.656 ns |    10,028.87 ns |  0.09 |    0.00 |      - |         - |
|         ForLoop |       True |           True |     10000 |     8,985.25 ns |     105.303 ns |        93.349 ns |     8,943.49 ns |  0.08 |    0.00 |      - |         - |
| IEnumerableLoop |       True |           True |     10000 |   110,936.20 ns |     582.053 ns |       454.429 ns |   110,816.00 ns |  0.98 |    0.01 |      - |      40 B |
|                 |            |                |           |                 |                |                  |                 |       |         |        |           |
|         LinqSum |       True |           True |    100000 | 7,653,928.14 ns | 664,223.795 ns | 1,958,478.847 ns | 7,502,062.18 ns |  1.00 |    0.00 |      - |      45 B |
|     ForEachLoop |       True |           True |    100000 |   401,428.98 ns |  10,196.038 ns |    29,580.556 ns |   395,871.92 ns |  0.06 |    0.01 |      - |         - |
|         ForLoop |       True |           True |    100000 |   329,353.64 ns |   6,499.721 ns |    15,697.556 ns |   326,606.64 ns |  0.04 |    0.01 |      - |         - |
| IEnumerableLoop |       True |           True |    100000 | 4,937,252.79 ns | 114,227.695 ns |   322,181.239 ns | 4,816,144.54 ns |  0.69 |    0.18 |      - |      45 B |
