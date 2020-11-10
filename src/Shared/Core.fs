module Core

module Option =
    let getValueOr x y =
        match y with
        | Some s -> s
        | None -> x

module Async =
    let map f a = async{
        let! x = a
        return f x
    }