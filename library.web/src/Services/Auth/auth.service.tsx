import axios from "axios";
import ISigninData from "../../types/auth/signin";
import ISignupData from "../../types/auth/signup";


class AuthService {

    login(username : string, password : string) {
        const formData = new FormData();
        formData.append("userName", username);
        formData.append("password", password);
        return axios
            .post<ISigninData>( process.env.REACT_APP_API_URL + '/Auth/BearerToken', formData)
            .then((response : any) => {
                if (response.data.token) {
                    localStorage.setItem("user", JSON.stringify(response.data));
                }
                return response.data;
            });
    }

    logout() {
        localStorage.removeItem("user");
        localStorage.removeItem("username");
    }

    register(data: ISignupData) {
        const formData = new FormData();
        formData.append("userName", data.username);
        formData.append("email", data.email);
        formData.append("password", data.password);
        return axios.post<ISignupData>(process.env.REACT_APP_API_URL + "/Auth/registration", formData)
            .then((response: any) => {
                console.log(response)
            });
    }

    getCurrentUser() {
        // @ts-ignore
        return JSON.parse(localStorage.getItem('user'));
    }
}

export default new AuthService();