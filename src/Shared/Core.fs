module Core

module Option =
    let getValueOr x y =
        match y with
        | Some s -> s
        | None -> x

    let getValueOrDefault (o : 'a option when 'a : struct) = getValueOr Unchecked.defaultof<'a> o

    let optionOperation x y f = f (getValueOrDefault x) (getValueOrDefault y)

module Async =
    let map f a = async{
        let! x = a
        return f x
    }