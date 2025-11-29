/**
 * Converts an integer to a float starting with 0
 * @param {number} num - The integer number to convert
 * @returns {number} - The converted float starting with 0
 * @example
 * convert(12345) // returns 0.12345
 * convert(123) // returns 0.123
 * convert(1) // returns 0.1
 */
function convert(num) {
    if (num === 0) return 0;
    
    // Get the absolute value to handle negative numbers
    const absNum = Math.abs(num);
    
    // Count the number of digits
    const digits = Math.floor(Math.log10(absNum)) + 1;
    
    // Divide by 10^digits to get a number between 0 and 1
    const result = absNum / Math.pow(10, digits);
    
    // Preserve the sign
    return num < 0 ? -result : result;
}

module.exports = convert;
