# 1. We have two loops, which are nested. For each loop we have N steps, so the running time for two loops will be N * N (N^2).

# 2. The best case will be N steps - we have in column 0 only `odd numbers` and the second loop is not executed. The average case will be (N * (M / 2)) - some numbers in column 0 will be `even numbers`. The worst case will be N * M - all numbers are `even`, the second loop is executed every time. In summary, first loop will always be executed (N), but the execution of second loop depends on the first `if condition`(0, M / 2, M), so answer is (N * (M / 2)).

# 3. The answer is N * M steps. The loop is executed N times (rows) and the method CalcSum will be called M times recursively.