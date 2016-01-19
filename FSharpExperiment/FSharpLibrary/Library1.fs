namespace FSharpLibrary

open System
open System.Linq
open System.Collections.Generic

[<AbstractClass; Sealed>]
type Class1 private () =

   //   let totalSize = items |> Seq.sum_by (fun (i : Item) -> i.Size)

//      let mutable sum = 0.0
//      static member Sum(values) =           
//          for i in values do
//              sum <- sum + i

        static member Sum(values:IEnumerable<double>) = 
            Seq.sum (values)


  //  static member Mean(values) : IEnumerable<double> = 
  //      values.Sum()
   