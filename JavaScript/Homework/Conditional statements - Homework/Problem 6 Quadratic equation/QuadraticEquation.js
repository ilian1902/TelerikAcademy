// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
// and solves it (prints its real roots).
// Calculates and prints its real roots.
//    Note: Quadratic equations may have 0, 1 or 2 real roots.

var twoRoots = { a: 2, b: 5, c: -3 },
			sameRoots = { a: -0.5, b: 4, c: -8 },
			noRoots = { a: 5, b: 2, c: 8 };

console.log(twoRoots, solve(twoRoots));
console.log(sameRoots, solve(sameRoots));
console.log(noRoots, solve(noRoots));

function solve(equation) {
    var D = equation.b * equation.b - 4 * equation.a * equation.c;
    if (D < 0) {
        return "no real roots";
    }
    else if (D == 0) {
        return getRoot(-1, D, equation.b, equation.a);
    }
    else {
        return [getRoot(1, D, equation.b, equation.a), getRoot(-1, D, equation.b, equation.a)];
    }
}

function getRoot(sign, D, b, a) {
    return (-b + Math.sqrt(D) * sign) / (2 * a);
}