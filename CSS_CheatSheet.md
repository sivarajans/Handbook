# Cascading Style Sheet Cheat Sheet

Possible values are represented in _[ ]_, provide any one values from the array box.

#### Define the charset of CSS
```css
@charset "ISO-enANY"
```

#### font-face Definition
```css
/* example */
@font-face {    
  font-family: new-font-name;    
  src:url('');    
  /* other font css ... */
}
```

#### Media Queries 
```css
@media screen, print { } 

/* example */
<link rel="stylesheet" media="screen and (min-width:40px) and (max-width:100px)" href="docPath.css"/>
```

#### background
```css
background: color image repeat attachment vertical-position horizontal-position;

attachement => [fixed | scroll | inherit]
vertical-position => [top | bottom | center]
horizontal-position => [left | right | center]

/* example */
backgorund: red url("home.png") no-repeat fixed 10px 10px;
backgorund: transparent none no-repeat inherit 0 0; 

/* other background props */
background-clip: [border | padding]
background-size: 50px 30px;

```

#### brder & outline & border-radius
```css
border: width style color;
outline: color style width;
border-radius: 3px;

style => [dashed | dotted | double | groove | hidden | inset | none | outset | ridge | solid]

/* example */
border: 1px solid red;
border: 2px solid rgb(40, 40, 40);
border: 3px dashed #fff;
outline: red solid 1px;

/* other border props */
border-collapse: collapse;
```
#### box-shadow
```css
box-shadow: color x-offset y-offset blur-radius spead-radius;

/* example */
box-shadow: red 1px 3px 30px 2px;
```

#### box-sizing
```css
box-sizing: [border-box | content-box]
```

#### opacity
max value is 1 indicating visible.
```css
/* example */
opacaity: 1;
```

#### border-image
```css
border-image: source slice width outset repeat;

/* example */
border-image: url(background-image) 50px 20px 100px 30px repeat;
```

#### top, bottom, left, right 
Positioned elements works with these css. (fixed, absolute, relative) other than static/initial position.
```css
/* example */
top: 5px;
bottom: 1em;
left: 2cm;
right: 3px;
```

#### float
moves the element to the given side.
```css
float: [left | right]

/* example */
float: left;
```

#### clear
works to clear side of floated elements.
```css
clear: [both | left | right]

/* example */
clear: both;
```

#### color
```css
/* example */
color: red;
```

#### content
Only works with `:before` or `:after` syntax
```css
/* example */
content: ' '
```

#### cursor
```css
cursor: [auto | pointer | crosshair | help | ...]

/* example */
cursor: pointer;
```

#### display
Set the display type for the element, display: none hides the element with no space in UI.
```css
display: [ inline | block | list-item | run-in | inline-block | table | inline-table | table-row-group | table-header-group | table-footer-group | table-row | table-column-group | tablecolumn | table-cell | table-caption | none | inherit ]

/* example */
display: block;
```

#### font
```css
font: style varient weight size family;

style => [normal | italic | oblique]
varient => [normal | small-caps]
weight => [normal | bold | lighter | bolder | 100 through 900 | ...]
family => 'font-face-value or local fonts'

/* example */
font: italic small-caps 100 20px Calibri;
font: normal normal normal 1em Calibri;
```

#### width and height properties
```css
/* example */
min-height: 100px;
height: 200px;
max-height: 300px;

min-width: 100px;
width: 300px;
max-width: 500px;
```

#### Text Properties
```css
/* example */
letter-spacing: 2px;
word-spacing: 2px;
line-height: 2;
text-align: [center | left | right | ...]
text-decoration: [dashed | dotted | line-through | underline | ...]
text-indent: 2px;
text-transform: [capitalize | uppercase | lowercase | ...]
word-break: [break-all | break-word | ...]
word-wrap: [break-word | ...]


text-shadow: horizontal-offset vertical-offset blur-radius color;

/* example */
text-shadow: 1px 2px 10px red;
```

#### list-style
```css
list-style: [circle | disc | none | ...]

/* example */
list-style: none;
```

#### margin & padding
Spacing elements through margin and padding properties.
```css
margin: top right bottom left;
padding: top right bottom left;

/* example */
margin: 2px;
margin: 2px 3px;
margin: 3px 2px 1px 0;

padding: 3px;
padding: 5px 3px;
padding: 3px 3px 0 0;
```
#### overflow
Set effect when element is overflow from its container
```css
overflow: [auto | scroll | hidden | visible]

/* example */
overflow: hidden;
```

#### position
Set the positioned value of element
```css
position: [intial | static | absolute | fixed | relative]

/* example */
position: absolute;
```

#### visibility
Hides the element from UI, but allocates the space.
```css
visibility: [visible | collapse | hidden | ...]

/* example */
visibility: hidden;
```

#### z-index
Layering the controls, higher value gets layered on top.
```css
/* example */
z-index: 5;
```

#### keyframes
keyframes are used in animation-name property.
```css
@keyframes keyframename 
{ 
  from {...css} 
  percentage {...css} 
  to {...css} 
}

/* example */
@keyframes keyframename {
  from {top: 0px;}
  20% { top: 100px }
  to {top: 200px;}
}
```

#### animation
Animative effect on elements.
```css
animation: name duration timing-function delay iteration-count direction;

timing-function => [cubicbezier(number,number,number,number) | ease | ease-in | ease-in-out | ease-out | linear]
iteration-count => [infinite | 1 to ... ]
direction => [normal | alternate]

/* example */
animation: animation-name 20s ease-in 1s 10 normal; 
```
#### perspective
Sets the 3d perspective.
```css
/* example */
perspective: 20px;
perspective-origin: 50% 50%;
```

#### transform
Change element view position, angle, make size changes, skew changes.
```css
/* short hand form */
transform: rotate(angle) scale(x-axis-scale, y-axis-scale) skew(x-axis-angle, y-axis-angle) translate(x-axis-size, y-axis-size);

transform: rotateX(angle) rotateY(angle) rotateZ(angle) scaleX(scale) scaleY(scale) skewX(angle) skewY(angle) translateX(size) translateY(size);

/* example */
transform: rotate(45deg) scale(1.2, 1.2);
transform: rotate(30deg) scale(1, 1) skew(20deg, 20deg) translate(10px, 10px); 
transform: rotateX(30deg) rotateY(20deg) rotateZ(10deg) scaleX(1.1) scaleY(1.2) skewX(20deg) skewY(20deg) translateX(10px) translateY(20px);
transform: rotateX(30deg) scaleX(1.1);
```

#### transform-origin
Sets the base of ratoted element (works with transform)
```css
transform-origin: [left | right | center | top | bottom]

/* example */
transform-origin: left;
```

#### transform-style
Set the 3d plane of child elements, if preserve-3d, child elements get its own 3d plane.
```css
transform-style: [flat | preserve-3d]

/* example */
transform-style: flat;
```

#### transition
Animative property for user interactions.
```css
transition: property duration timing-function delay;

property => any supported css property name
timing-function => [cubicbezier(number,number,number,number) | ease | ease-in | ease-in-out | ease-out | linear]

/* example */
transition: color 1s ease-in 0.1s;
color: red;
```

#### backface-visibility
Rotated element will have reverse info post 90 degree movement, this property allows to hide or show it, will the content as mirrored when visible.
```css
backface-visibility: [hidden | visible]

/* example */
backface-visibility: visible;
```

#### Graidents 
Gradients are very useful for replacing image properties and achieve greater effect.
```css
linear-gradient (start-angle, color until-percentage, color until-percentage, ..., color 100%)
repeating-linear-gradient (start-angle, color until-percentage, color until-percentage, ..., color 100%)

radial-gradient (radial-position-x radial-position-y, color until-percentage, color until-percentage, ..., color 100%)
repeating-radial-gradient (radial-position-x radial-position-y, color until-percentage, color until-percentage, ..., color 100%)

/* example */
background: linear-gradient(30deg, red 0%, blue 65%, green 80%, yellow 100%);

/* before 35% repeating applied */
background: repeating-linear-gradient(30deg, red 35%, blue 65%, green 80%, yellow 100%);

background: radial-gradient(50% 50%, red 35%, blue 65%, green 80%, yellow 100%);

/* when value of radial-position goes below 50%, repeating gradient shows up. if more than 50% then it can show only one cycle. */
background: repeating-radial-gradient(20% 20%, red 35%, blue 65%, green 80%, yellow 100%);
```

