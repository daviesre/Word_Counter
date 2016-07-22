# _Word Counter with C#, Nancy, and Razor_

#### _A site counting the frequency of a word in a sentence_

#### By _**Russ Davies**_

## Description/Specs

| Behavior        | Input Example           | Output Example  | Reason |
| ------------- |:-------------:| -----:|
| The user inputs a letter and one is returned | 'A' | 1 |
| The user inputs a word and one is returned | "cat" | 1 |
| The user inputs multiple letters and the equivalent amount of a letter is returned | "A B" | 1 'A' |
| The user inputs a sentence and the equivalent amount of a chosen word is returned | "How are you?" | 1 "are" |
| The user inputs a word and sentence and returns the correct amount of the word regardless of capitalization | "APple APPLE apple" | 1 apple |
| The user inputs a sentence with common punctuation and returns the correct amount of the word | "This is a test." | 1 test |

* Behavior 1: A single letter such as 'A' is the exact requirement needed for this spec.
* Behavior 2:  I chose "cat" because it is a basic word that is not too long, yet recognizable as a noun.
* Behavior 3: Adding "B" to a string of "A B" is the least complicated amount of letters I can add.
* Behavior 4: This is one of the most basic sentences in the English language to test for word frequency.
* Behavior 5: This input shows off the many different ways a word can be capitalized and yet still return a correct result.
* Behavior 6:  Using a period is the most basic way a sentence could be messed up from a word count

## Setup

 Clone this repository, and on your pre-configured Epicodus computer, run "DNU restore" at the PowerShell prompt in the top directory of the cloned repository. Then type in "DNX Kestrel" at the same prompt and a local instance of the kestrel server will boot. Navigate in your browser to "LocalHost:5004" to view the homepage.

## Known Bugs
No known bugs

## Support and contact details
Please contact the authors if you have any questions or comments.

## Technologies Used
This webpage was written using C#, Nancy, and Razor.

### License
Copyright (c) 2016 _**Russ Davies **_

This software is licensed under the MIT license.
