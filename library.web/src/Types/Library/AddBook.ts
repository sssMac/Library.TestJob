export default interface IAddBookData {
    name: string,
    year: string,
    authors: [
        {
            id? : any | null,
            name : string
        }],
    genres: [
        {
            id? : any | null,
            name : string
        }],
}
