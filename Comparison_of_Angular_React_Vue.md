# My Handbook of Javascript framework / libraries

## Angular 
It is a open-source web application _framework_ written in javascript and typescript. _By Google_

## React
React is a open-source libray written in javascript. _By Facebook_

## Vue
It is open-source model-view-viewmodel framework written in javascript and typescript.



## Comparison
Below given tables with their comparision for easy understanding.


### Data Types
| Angular / Vue | React |
|---|---|
|_type-script_ is used in angular and vue <br/> `any` <br/> `void` <br/> `boolean` <br/> `Number` <br/> `array` <br/> `string` <br/> `tuple` <br/> `enum` <br/> `unknown` <br/> `null` <br/> `undefined` <br/> `never` <br/> `object` <br/> `string \| number` union tpe <br/> `class1 & class2` intersection type | _prop-types_ defined types <br/> `any` <br/> `string` <br/> `number` <br/> `func` <br/> `bool` <br/> `oneOf(any)` <br/> `oneOfType(type array)` <br/> `array` <br/> `arrayOf(...)` <br/> `object` <br/> `objectOf(...)` <br/> `instanceOf(...)` <br/> `shape(...)` <br/> `element` <br/> `node` <br/> `(...).isRequired` to make required 


### HTML Binding Patterns
|   Usage | Angular | React | Vue |
|---|---|---|---|
| OneWay Binding | `[attribute]="expression"` <br/> `bind-attribute="expression"` - canonical form <br/> `{{variable}}` - interpolation | `attribute={variable}` <br/> `{{variable}}` - interpolation | `:attribute="expression"` or <br/> `v-bind:attribute="expression"` - canonical form <br/><br/> `v-text:attribute="expression"` <br/> `v-html:attribute="expression"` <br/> `v-once:attribute="expression"` <br/> `{{variable}}` - interpolation|
| Event Binding  | `(event)="expression"` or <br/> `on-event="expression"` - canonical form | `camelCaseEventName="expression"` | `@event="expression"` or <br/> `v-on:event="expression"` - canonical form  <br/><br/> `@event.native="expression"` - dom native event <br/> `@event.stop="expression"` - stops propagation <br/> `@event.passive="expression` - through addEventListener <br/> `@event.capture="expression"` - event capturning not bubbling <br/> `@event.self="expression"` - triggers only on that element event <br/> `@event.once="expression"` - only once <br/> `@submit.prevent="expression"` - prevent default <br/><br/> Mouse specific events (left, right, middle clicks) <br/> `@click.left="expression"` <br/> `@click.right="expression"`<br/> `@click.middle="expression"` <br/><br/> Keyboard specific events <br/> `@keyup.enter` <br/> `@keyup.tab` <br/> `@keyup.delete` <br/> `@keyup.esc` <br/> `@keyup.up` <br/> `@keyup.down` <br/> `@keyup.left` <br/> `@keyup.right` <br/><br/> Keyboard event modifiers <br/> `@kbevent.ctrl` <br/> `@kbevent.alt` <br/> `@kbevent.alt` <br/> `@kbevent.meta` <br/><br/> Specials <br/> `:attribute.prop` - to prop instead of attribute  <br/> `:attribute.camel` - cameCase for attributename <br/> `:attribute.sync` - v-on handler syntactic sugar |
| TwoWay Binding | `[(attribute)]="expresssion"` or <br/> `bindon-attribute="expression"` - canonical form | _achieved using state variables_ | `v-bind:attribute="expression"` |
| Reference/ Local Variable | `#name` as attribute or <br/> `ref-name` - canonical form |  `ref="{el => this.refEl = el}"` now use `this.refEl` | _none_ |
| Embedded Template | `*attribute="expression"` <br/> wrapped as `<ng-template><tag [atrribute]="expression"></ng-template>` | _none_ | 
| CSS Binding | `style={{camelCase: value}}` or <br/> `[ngStyle]={cssProp: value}` or <br/> `[ngClass]={'classname': bool-expression, ...}`<br/> | `style={{camelCase: value}}` | `style={{camelCase: value}}` |
| If | `*ngIf="bool-expression"` | `{true ? jsx : jsx}` | `v-if="expression"`, `v-else-if="expression"`, `v-else="expression"` |
| For | `*ngFor="let it of item"` | `{items.map(i => <div>{{i}}</div>)}` | `v-for todo` |
| Show / Hide | | | `v-show="bool-expression"`
| Switch | `[ngSwitch]="expression"` <br/> `[ngSwitchCase]="case-expresssion"` <br/> `ngSwitchDefault` | _none_ | 
| Pipe | `{value \| pipe}` | _can be acheived by javascript functions directly_ | |
| Framework  / Library classes | `ng-pristine` - not touched <br/> `ng-dirty` - touched <br/> `ng-invalid` - input invalid <br/> `ng-valid` - input valid <br/> `ng-touched` - user touched <br/> `ng-untouched` - user not touched | _none_ 


### Life Cycle
|   Usage | Angular | React | Vue |
|---|---|---|---|
| Lifecycle | `constructor(services : Service, ...)` <br/> `ngOnChanges(changes)` <br/> `ngOnInit()` <br/> `ngDoCheck()` <br/> `ngAfterContentInit()` <br/> `ngAfterViewInit()` <br/> `ngAfterContentChecked()` <br/> `ngAfterViewChecked()` <br/> `ngOnDestroy()` <br/><br/> Guards <br/> `CanActivate` <br/> `CanDeactivate` <br/> `CanActivateChild` <br/> `Resolve` <br/> `CanLoad`  | `constructor(props)` <br/> `componentDidMount()` <br/> `componentWillUnMount()` <br/> `componentDidCatch(error, info)` <br/> `componentDidUpdate(prevProps, prevState, snapshot)` <br/>`shouldComponentUpdate(nextProps, nextState)` <br/> `render()` <br/></br> Rare Events <br/> `static getDerivedStateFromProps(props, state)` <br/> `getSnapshotBeforeUpdate(prevProps, prevState)` <br/>  `static getDerivedStateFromError(error)` | `beforeCreate` <br/> `created` <br/> `beforeMount` <br/> `mounted` <br/> `beforeUnmount` <br/> `unmounted` <br/> `beforeUpdate` <br/> `updated` <br/> `activated` <br/> `deactivated` |
| Routes| routing handled via `@angular/router` <br/> `RouterModule.forRoot(routes)` <br/> `RouterModule.forChild(routes)` | routing can be handled via `react-router` / `react-router-dom` | 

### Library / Framework Differences
|  Usage | Angular | React | Vue |
|---|---|---|---|
| Properties | `@Input('Alias2PropOptional') decorator` | `this.prop` and `this.state` | 
| Event Declaration | `@Output('Alias2EventOptional')` decorator as `EventEmitter` | _none_ | |
| Module | `@NgModule({ declarations: ..., imports: ..., exports: ..., providers: ..., bootstrap: ..., entryComponents: ...}) class MyModule {...}` | _none_ | |
| Component | `@Component({moduleId: id, template:..., templateUrl:..., styles:[...], styleUrls:[...]})` decorator | `class SomeComponent extends React.Component {` <br/> `constructor(){} `<br/>  `render(){} `<br/> `}`  | Component is object like <br/> `export default {` <br/> `name:'component-name'` <br/> `components:{ 'imported-components' },` <br/> `data():{},` <br/> `computed:{},` <br/> `methods:{},` <br/> `props:{},` <br/> `watch:{},` <br/> `}` |
| Directive | `@Directive({selector:css-selector, providers:[...])` decorator | _none_ | 
| Pipe | `@Pipe({...})` decorator | _none_ | 
| Services | `@Injectable()` decorator | _directly call api  by import/require_ 
| Function Component| _none_ |  `function Comp(prop) { return <div></div> }` | |
| Hooks & Effects | _none_ | `useState` <br/> `setState` <br/> `useEffect`
| Specials Decorators | `@HostBinding()` <br/> `@HostListener('event', 'args')` <br/> `@ContentChild(predicate)` <br/> `@ContentChildren(predicate)` <br/> `@ViewChild(predicate)` <br/> `@ViewChildren(predicate)` | _none_ | 



## APIs
|  Usage | Angular | React | Vue |
|---|---|---|---|
| APIs | `platformBrowserDynamic().bootstrapModule(AppModule);` | `React.createClass({...})` <br/> `ReactDOM.render(<component />, domNode, callback)` <br/> `ReactDOMServer.renderToString(<component />)` <br/> `ReactDOMServer.renderToStaticMarkup(<component />)` <br/> `ReactDOM.hydrate(<component/>, domNode)` | `Vue.createApp(ComponentFunction).mount('css-selector-to-mount')`



Thank you for reading my docs.   
If you feel anything can be updated, please create pull request.
