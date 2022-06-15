type AutoCompleteResult =
    { id: string;
      label: string;
      value: string }

[<Controller>]
module Commune =
    let get (term: string) (store: IDocumentStore) =
        use session = store.OpenSession()
        let postcodeRegex = new Regex(@"^\d+$")

    let comQuery =
session.Advanced.LuceneQuery<Commune>("Communes/Search")

    let comQuery =
        if postcodeRegex.IsMatch term then
            comQuery.WhereStartsWith("Postcode", term)
    else
        comQuery.WhereStartsWith("Name", term)
    let query = comQuery.Take(20)
    let res = query |> Seq.map (fun x -> { id = x.Id; label = sprintf "%s
(%s)" x.Name x.Postcod