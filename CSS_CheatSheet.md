# Cascading Style Sheet Cheat Sheet

Possible values are represented in _[]_, provide any one values from the array box.

#### Define the charset of CSS
```css
@charset "ISO-enANY"
```

#### font-face Definition
```css
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

#### background-color
```css
background: color image repeat attachment vertical-position horizontal-position;

attachement: [fixed, scroll, inherit]
vertical-position: [top, bottom, center]
horizontal-position: [left, right, center]

/* example */
backgorund: red url("home.png") no-repeat fixed 10px 10px;
backgorund: transparent none no-repeat inherit 0 0; 
```

#### brder
```css
border: width style color;

border-style: [dashed, dotted, double, groove, hidden, inset, none, outset, ridge, solid]

/* example */
border: 1px solid red;
border: 2px solid rgb(40, 40, 40);
border: 3px dashed #fff;
```

#### border-collapse
```css
border-collapse: collapse;
```

#### top, bottom, left, right 
Positioned elements works with these css. (fixed, absolute, relative) other than static/initial position.
```css
top: 5px;
bottom: 1em;
left: 2cm;
right: 3px;
```

#### float
moves the element to the given side.
```css
float: [left, right]

/* example */
float: left;
```

#### clear
works to clear side of floated elements.
```css
clear: [both, left, right]

/* example */
clear: both;
```

#### color
```css
color: red;
```

#### content
works only with `:before` or `:after`
```css
content: ' '
```

#### cursor
```css
cursor: [auto, pointer, crosshair, help, ...]
```


