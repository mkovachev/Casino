# Casino

Simple Casino console application build with ASP.NET 5. It can be extended with any additional casino play you may want.

## Features

The Casino has currently one slot machine implemented.

## Slot Machine

<ol>
<li>The slot machine consists of 4 rows of 3 symbols each.</li>
<li>Each symbol has a probability chance to appear and a coefficient, which is used for calculating the stage won amount. The <br>won amount</br> is the sum of the coefficients of the symbols on the winning
row(s), multiplied by the bet amount. The <b>total balance</b> calculation formula is as follows:</li>
<li><b>{Total balance} = ({Total balance} - {Bet amount}) + {Won amount}</b></li>
<li>The Wildcard symbol can match with any other symbol, but has a coefficient of 0</li>
</ol>

![alt text](https://github.com/mkovachev/OldMacDsFarm/blob/main/src/assets/images/home.PNG)

## Slot Play

<ol>
<li>At the start of the game, the player should enter the initial money balance.</li>
<li>After that, for each spin, the player is asked how much money he wants to bet.</li>
<li>The win/loose amount of each spin is displayed to the player, together with the total balance.</li>
<li>The game ends when the total balance hits 0.</li>

![alt text](https://github.com/mkovachev/OldMacDsFarm/blob/main/src/assets/images/home.PNG)

<li>Player has staked 70 and winning coefficient is 1.2 + 1.2 = 2.4 , so the won amount is: 70 * 2.4 = <b>168</b>.</li>
<li>The won amount is then added to the total balance of the player (500 – 70) + 168 = <b>598</b>.</li>
</ol>
