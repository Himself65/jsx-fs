namespace parser
open System.Text.RegularExpressions

module Parser =
    let parse (str: string) =
        let regex = Regex @"(?<=\<).*?(?=>)"
        let res = regex.Match str
        for i in res.Groups do
            // todo
