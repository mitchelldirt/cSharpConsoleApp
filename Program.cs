// string message = "Find what is (inside the parentheses)";
//
// int openingPosition = message.IndexOf("(");
// int closingPosition = message.IndexOf(")");
//
// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);
//
// openingPosition += 1;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";
//
// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");
//
// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";
//
// const string openSpan = "<span>";
// const string closeSpan = "</span>";
//
// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);
//
// openingPosition += openSpan.Length;
//
// int length = closingPosition - openingPosition;
//
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');
//
// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;
//
//     openingPosition++;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
//
//     message = message.Substring(closingPosition + 1);
// }

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int closingPosition = 0;
//
// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//
//     if (openingPosition == -1) break;
//
//     string currentSymbol = message.Substring(openingPosition, 1);
//
//     char matchingSymbol = ' ';
//
//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }
//
//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);
//
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// string data = "12345Josh Smith         5000     3";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);
//
// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
string openSpan = "<span>";
string closeSpan = "</span>";

int openSpanPosition = input.IndexOf(openSpan);
openSpanPosition += openSpan.Length;

int closeSpanPosition = input.IndexOf(closeSpan);
int length = closeSpanPosition - openSpanPosition;

quantity = input.Substring(openSpanPosition, length);

string openDiv = "<div>";
string closeDiv = "</div>";
int openDivPosition = input.IndexOf(openDiv);

string newInput = input.Remove(openDivPosition, openDiv.Length);

int closeDivPosition = newInput.IndexOf(closeDiv);
newInput = newInput.Remove(closeDivPosition, closeDiv.Length);

newInput = newInput.Replace("&trade;", "&reg;");
output = newInput;

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");