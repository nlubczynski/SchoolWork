// global variables

// starting position of 0
var position = 0;
// starting page of 0
var page = 0;
// number of elements displayed per page
var linesPerPage = 30;
// our selection of colours
var colours = new Array('blue', 'green', 'red', 'yellow', 'orange', 'purple',
		'brown', 'aliceblue', 'azure', 'blanchedalmond', 'burlywood', 'coral',
		'cyan', 'darkgray', 'darkmagenta', 'darkred', 'darkslategray',
		'deeppink', 'dodgerblue', 'fuchsia', 'goldenrod', 'grey', 'indigo',
		'lavenderblush', 'lightcoral', 'lightgreen', 'lightseagreen',
		'lightsteelblue', 'linen', 'mediumblue', 'mediumslateblue',
		'midnightblue', 'navajowhite', 'olivedrab', 'palegoldenrod',
		'papayawhip', 'plum', 'rosybrown', 'sandybrown', 'silver', 'slategrey',
		'tan', 'turquoise', 'whitesmoke', 'antiquewhite', 'beige', 'cadetblue',
		'cornflowerblue', 'darkblue', 'darkgreen', 'darkolivegreen',
		'darksalmon', 'darkslategrey', 'deepskyblue', 'firebrick', 'gainsboro',
		'gray', 'honeydew', 'ivory', 'lawngreen', 'lightcyan', 'lightgrey',
		'lightskyblue', 'lightyellow', 'magenta', 'mediumorchid',
		'mediumspringgreen', 'mintcream', 'navy', 'palegreen', 'peachpuff',
		'powderblue', 'royalblue', 'seagreen', 'skyblue', 'snow', 'teal',
		'violet', 'aqua', 'bisque', 'blueviolet', 'chartreuse', 'cornsilk',
		'darkcyan', 'darkgrey', 'darkorange', 'darkseagreen', 'darkturquoise',
		'dimgray', 'floralwhite', 'ghostwhite', 'hotpink', 'khaki',
		'lemonchiffon', 'lightgoldenrodyellow', 'lightpink', 'lightslategray',
		'lime', 'maroon', 'mediumpurple', 'mediumturquoise', 'mistyrose',
		'oldlace', 'orangered', 'paleturquoise', 'peru', 'saddlebrown',
		'seashell', 'slateblue', 'springgreen', 'thistle', 'wheat',
		'yellowgreen', 'aquamarine', 'black', 'chocolate', 'crimson',
		'darkgoldenrod', 'darkkhaki', 'darkorchid', 'darkslateblue',
		'darkviolet', 'dimgrey', 'forestgreen', 'gold', 'greenyellow',
		'indianred', 'lavender', 'lightblue', 'lightgray', 'lightsalmon',
		'lightslategrey', 'limegreen', 'mediumaquamarine', 'mediumseagreen',
		'mediumvioletred', 'moccasin', 'olive', 'orchid', 'palevioletred',
		'pink', 'salmon', 'sienna', 'slategray', 'steelblue', 'tomato', 'white');
// how many elements are scrolled for one 'click' of the mouse scroll
var scrollSpeed = 5;
//maxmium number of colours
var maxNumber = colours.length;



// onload, bind the scroll to our event
window.onload = function() {

	// adding the event listerner for Mozilla
	if (window.addEventListener)
		document.addEventListener('DOMMouseScroll', scrollObject, false);

	// for IE/OPERA etc
	document.onmousewheel = scrollObject;

	// add the base DOM elements
	for (var i = 0; i < linesPerPage; i++) {
		var element = document.createElement('div')
		element.setAttribute('id', 'div' + i);
		document.getElementById('mainWindow').appendChild(element);
	}
	render();
}
// on scroll, normalize and trigger poistionChange function
function scrollObject(event) {
	var delta = 0;

	if (!event)
		event = window.event;

	// normalize the delta
	if (event.wheelDelta) {

		// IE and Opera
		delta = event.wheelDelta / 60;

	} else if (event.detail) {

		// W3C
		delta = -event.detail / 2;
	}

	if (event.wheelDelta > 0)
		positionChange(true);
	else
		positionChange(false);

	// return false to prevent the window from scrolling
	return false;
}
// on resize, lets figure out the height and then divide that by the number of
// vertical divs.
window.onresize = function(event) {

	var viewportwidth;
	var viewportheight;

	// the more standards compliant browsers (mozilla/netscape/opera/IE7) use
	// window.innerWidth and window.innerHeight

	if (typeof window.innerWidth != 'undefined') {
		viewportwidth = window.innerWidth, viewportheight = window.innerHeight
	}

	// IE6 in standards compliant mode (i.e. with a valid doctype as the first
	// line in the document)

	else if (typeof document.documentElement != 'undefined'
			&& typeof document.documentElement.clientWidth != 'undefined'
			&& document.documentElement.clientWidth != 0) {
		viewportwidth = document.documentElement.clientWidth, viewportheight = document.documentElement.clientHeight
	}

	// older versions of IE

	else {
		viewportwidth = document.getElementsByTagName('body')[0].clientWidth, viewportheight = document
				.getElementsByTagName('body')[0].clientHeight
	}
	// shrink everything to be a little safe / give a border
	viewportwidth *= .9;
	viewportheight *= .9;

	// change the size of the inner div elements that contain stuff
	for (var i = 0; i < linesPerPage; i++)
		document.getElementById('div' + i).setAttribute(
				'style',
				'height:' + viewportheight / linesPerPage + 'px;' + 'width:'
						+ viewportwidth / linesPerPage + 'px;');

}
function positionChange(isUP) {


		//go up or down
		position = isUP ? position - scrollSpeed : position + scrollSpeed;
		
		// make it circular
		
		// if you go above the lines per page, go back to zero and increment the
		// page up
		if (position > linesPerPage) {
			position = 0;
			page++;
		}
	
		// if you go below zero, loop back to the top, or, the number of lines per
		// page
		// however this depends on which page you are on. If you are on page 0 then
		// you should be stuck at 0, you are at the top
		if (position < 0) {
			position = page > 0 ? linesPerPage : 0;
			page = page > 0 ? page - 1 : page;
		}
		
		//Find the maxmium number of rows, if you've reached that, freeze going up
		var numberOfRows = 0;
		for(var i = 1; i <= maxNumber; i++)
			numberOfRows += Choose(maxNumber, i) * Factorial(i);
		
		//if we're over go back the amount we're over
		var pageProxy = page > 0 ? page + 1 : page;
		var singleRow = page > 0 ? 1 : 0;
		if( pageProxy +  position/linesPerPage > numberOfRows / linesPerPage)
			position -= pageProxy * linesPerPage +  position - numberOfRows * singleRow;
			
		//call the render
		render();
	
}
function render() {
	
	var DOMelements = new Array();

	// prep the new DOM elements
	for (var i = 0; i < linesPerPage; i++) {
		// create element
		var element = document.createElement('div');
		// name element by naming convetion
		element.setAttribute('id', 'div' + i);
		// pass the node to the logic determined in nodeCreator based off of
		// this nodes 'position'
		element = nodeCreator(
				element, (i + position)	% linesPerPage + ((parseInt((i + position) / linesPerPage) + page) * linesPerPage))
		// add it to our array
		DOMelements.push(element);
	}

	// swap the DOM elements
	for (var i = 0; i < DOMelements.length; i++) {
		var newEl = DOMelements[i];
		var oldEl = document.getElementById('div' + i);

		document.getElementById('mainWindow').removeChild(oldEl);
		document.getElementById('mainWindow').appendChild(newEl);
	}
}
// logic behind asking for combinations and permutations
function nodeCreator(element, number) {

	// get the base combination we are on
	var i = 0;
	var testLimit = 0;
	do
		testLimit += Choose(maxNumber, ++i) * Factorial(i);
	while (number >= testLimit && i < maxNumber);
	var combination = i;

	// subtract all the lower combination values from the number
	// we will then be left with the iteration in the current permutation
	for (i = 1; i <= combination - 1; i++)
		number -= Choose(maxNumber, i) * Factorial(i);

	// get the permutation we are on within that combination
	// divide this iteration with the number of numbers per permutation at this
	// level
	var combinationRow = parseInt(number / Factorial(combination));

	// the numbers in the combination set
	var combinationSet = ithCombination(maxNumber, combination,
			combinationRow);

	// the ithPermutation solves for 1-n not the random numbers we have in the
	// combination
	// therefore, solve the translationArray at our permutation generically then
	// map that to our combination set
	var translationArray = ithPermutation(combinationSet.length, number
					% Factorial(combination));

	var number = translate(combinationSet, translationArray);

	var returnElement = document.createElementNS("http://www.w3.org/2000/svg",
			"svg");
	returnElement.setAttribute("version", "1.2");
	returnElement.setAttribute("baseProfile", "tiny");

	for (i = 0; i < number.length; i++) {
		childEl = createCircleHTML(number[i], i);
		returnElement.appendChild(childEl);
	}

	element.appendChild(returnElement);

	return element;

}
// returns i permutation of 0 - n entries (0 inclusive n not)
// for example: ithPermutation(10,3628799) -> the 3628799th permutation of
// 0,1,2,3,4,5,6,7,8,9
// returns [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]
function ithPermutation(n, i) {
	var j, k = 0;
	var fact = new Array(n);
	var perm = new Array(n);

	// compute factorial numbers
	fact[k] = 1;
	while (++k < n)
		fact[k] = fact[k - 1] * k;

	// compute factorial code
	for (k = 0; k < n; ++k) {
		perm[k] = parseInt(i / fact[n - 1 - k]);
		i = i % fact[n - 1 - k];
	}

	// readjust values to obtain the permutation
	// start from the end and check if preceding values are lower
	for (k = n - 1; k > 0; --k)
		for (j = k - 1; j >= 0; --j)
			if (perm[j] <= perm[k])
				perm[k]++;

	var returnArray = new Array()
	// print permutation
	for (k = 0; k < n; ++k)
		returnArray.push(perm[k]);

	return returnArray;

}
// returns the i combination of Choose(n, k)
// for example: ithCombination(10,5,64) -> the 64th combinatino of 10 choose 5
// returns [0, 2, 3, 5, 9]
function ithCombination(n, k, i) {

	var ans = new Array(k);
	var a = n;
	var b = k;
	var x = (Choose(n, k) - 1) - i;

	for (var i = 0; i < k; ++i) {
		ans[i] = LargestV(a, b, x);
		x = x - Choose(ans[i], b);
		a = ans[i];
		b = b - 1;
	}

	for (var i = 0; i < k; ++i) {
		ans[i] = (n - 1) - ans[i];
	}

	return ans;
}
// helper function for our ithCombitnation
// return largest value v where v < a and Choose(v,b) <= x
function LargestV(a, b, x) {
	var v = a - 1;

	while (Choose(v, b) > x)
		--v;

	return v;
}
// returns the value of the choose function
function Choose(n, k) {
	if (n < 0 || k < 0)
		return;
	if (n < k)
		return 0; // special case
	if (n == k)
		return 1;

	var delta, iMax;

	if (k < n - k) // ex: Choose(100,3)
	{
		delta = n - k;
		iMax = k;
	} else // ex: Choose(100,97)
	{
		delta = k;
		iMax = n - k;
	}

	var ans = delta + 1;

	for (var i = 2; i <= iMax; ++i) {
		ans = (ans * (delta + i)) / i;
	}

	return ans;
}
// factorial formula
// TODO error on negative n
function Factorial(n) {

	var returnVal = 1;
	for (var i = 1; i <= n; i++)
		returnVal *= i;

	return returnVal;

}
function translate(arraySrc, arrayMap) {

	for (var i = 0; i < arraySrc.length; i++) {
		arrayMap[i] = arraySrc[arrayMap[i]];
	}

	return arrayMap;
}
// create the svg image, draw it i -> locations over
function createCircleHTML(number, i) {

	if(number < maxNumber){
		var shape = document
				.createElementNS("http://www.w3.org/2000/svg", "circle");
		shape.setAttribute("cx", 10 * (i + 1) + 15 * i);
		shape.setAttribute("cy", 10);
		shape.setAttribute("r", 10);
		shape.setAttribute("fill", colours[number]);
		return shape;
		}
	else{
		var shape = document

				.createElementNS("http://www.w3.org/2000/svg", "circle");
		shape.setAttribute("r", 0);
		return shape;
	}

}
//when user clicks submit
function submit(){

	var maxNumberInput = document.getElementById("maxNumberInput").innerHTML;
	var maxNumberLocal = parseInt(maxNumberInput);
	var scrollSpeedInput = document.getElementById("scrollSpeedInput").innerHTML;
	var scrollSpeedLocal = parseInt(scrollSpeedInput);
	var doRender = false;
	
	//Handle the max number
	if(isNaN(maxNumberLocal))
		document.getElementById('maxNumberInput').innerHTML = "Error, not a number. Please enter a number between 1 - 147";
	else if(maxNumberLocal > 147 || maxNumberLocal < 1)
		document.getElementById('maxNumberInput').innerHTML = "Error, please enter a number between 1-147";
	else{
		maxNumber = maxNumberLocal;
		document.getElementById('maxNumberInput').innerHTML = "";
		document.getElementById('maxSpan').innerHTML = maxNumber;
		//go back to the top
		position = page = 0;
		//call a render
		doRender = true;
	}
	
	//Handle the scroll speed
	if(isNaN(scrollSpeedLocal))
		document.getElementById('scrollSpeedInput').innerHTML = "Error, not a number. Please enter a number between 1 - 29";
	else if(scrollSpeedLocal > 29 || scrollSpeedLocal < 1)
		document.getElementById('scrollSpeedInput').innerHTML = "Error, Please enter a number between 1 - 29";
	else{
		scrollSpeed = scrollSpeedLocal;
		document.getElementById('scrollSpeedInput').innerHTML = "";
		document.getElementById('scrollSpan').innerHTML = scrollSpeed;
		//go back to the top
	}
	
	if(doRender)
		render();
		
}
//clear the inputs
function clear(){
	
	document.getElementById('scrollSpeedInput').innerHTML = "";
	document.getElementById('maxNumberInput').innerHTML = "";
}
