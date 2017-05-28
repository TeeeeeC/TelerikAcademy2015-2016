function solve() {
    return function(from, to) {
        var divisor,
            maxDivisior,
            n,
            isPrime,
            primes = [];
        from = +from;
        to = +to;
        if (isNaN(from) || isNaN(to) || from === undefined || to === undefined) {
            throw new Error();
        }
        for (n = from; n <= to; n += 1) {
            maxDivisior = Math.sqrt(n);
            isPrime = true;
            for (divisor = 2; divisor <= maxDivisior; divisor += 1) {
                if(!(n %divisor)){
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && n > 1) {
                primes.push(n);
            }
        }

        return primes;
    }
}

console.log(solve(1,125));