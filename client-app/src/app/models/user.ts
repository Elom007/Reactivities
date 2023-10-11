export interface User {
    displayName: string;
    username: string;
    token: string;
    image?: string;
}
// ? simply means optional
export interface UserFormValues {
    displayName?: string;
    email: string;
    password: string;
    username?: string;
}