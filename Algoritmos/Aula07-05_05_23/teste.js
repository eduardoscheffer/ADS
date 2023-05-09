const ages = [32, 33, 16, 40, 281921];
const result = ages.reduce((acum, val) => Math.max(acum, val));

console.log(result);