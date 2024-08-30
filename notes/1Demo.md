## 1st demo

Look at the my-html-js-project folder. It contains a simple HTML file with a script tag that logs a message to the console. Open the HTML file in a browser and check the console to see the message.

Use the copilot "fix" command to fix 2 errors in the js file. 1st one should be 
```js
const index = cell.getAttribte('data-index');
```
should be replaced with notice that Attribute is misspelled. The correct code should be
```js
const index = cell.getAttribute('data-index');
```

```js	
currentPlayer = currentPlayer === 'X' ? 'X' : 'X';
```
should be replaced with notice that the ternary operator is not doing anything. The correct code should be
```js
currentPlayer = currentPlayer === 'X' ? 'O' : 'X';
```

Explain the js code, and the html code using copilot.

Showcase the inline code feature, can test on both the js and html code. Could happen it suggest already written code in the file. Use comments to nudge it in the right direction. Look at the other suggestions using ```ctrl enter```. Can also show ```ctrl i``` to show you can ask directly in the code editor.

Open the chat.

Say simply hellpo to get started. 
Ask for something not code related.
Ask for a joke.
Ask for a joke about CN from an API.

Ask something tech specific
Show the topics and use some example.