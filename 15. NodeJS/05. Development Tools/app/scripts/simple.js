var listen;

listen = function(el, event, handler) {
  if (el.addEventListener) {
    return el.addEventListener(event, handler);
  } else {
    return el.attachEvent('on' + event, function() {
      return handler.call(el);
    });
  }
};

var math;

math = {
  root: Math.sqrt,
  square: square,
  cube: function(x) {
    return x * square(x);
  }
};

alert("Three cubed is " + (math.cube(3)));
