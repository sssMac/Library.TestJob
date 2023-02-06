export default interface IEditBookData {
    id?: any | null,
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
