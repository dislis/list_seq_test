// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
 
let gold = (1.0 + Math.Sqrt(5.0) )/ 2.0

let getnumoftimes :int =   
    Console.Write("Give numper of values ")    
    let couldparse , numofvalues=Int32.TryParse(Console.ReadLine())   
    if couldparse then        
        numofvalues   
    else       
        0

[<EntryPoint>]

let main argv =
let out = [
for i = 0 to getnumoftimes-1 do
    let isok,x=Double.TryParse(Console.ReadLine())                    
    if isok then                        
        yield ( x , x * gold)
    else
        yield (0.0,0.0) ] 
for j in out do
    let f,s=j
    printfn "%f %f"  f s

let a=Console.ReadLine()
0 // return an integer exit code
