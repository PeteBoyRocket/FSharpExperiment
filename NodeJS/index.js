var _ = require('lodash');
var now = require('performance-now');

var values = [];

for (var i = 0; i < 10000000; i++)
{
	values.push(i);
}

var start = now();

var result = _.sum(values);

var stop = now();

console.log(stop - start);