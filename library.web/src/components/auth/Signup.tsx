import React, {useState, useRef, ChangeEvent} from "react";
import { useDispatch, useSelector } from "react-redux";

// @ts-ignore
import Form from "react-validation/build/form";
// @ts-ignore
import Input from "react-validation/build/input";
// @ts-ignore
import CheckButton from "react-validation/build/button";
// @ts-ignore
import { isEmail } from "validator";

import { register } from "../../actions/auth";
import ISignupData from "../../types/auth/signup";

const required = (value: any) => {
    if (!value) {
        return (
            <div className="alert alert-danger" role="alert">
                This field is required!
            </div>
        );
    }
};

const validEmail = (value: string) => {
    if (!isEmail(value)) {
        return (
            <div className="alert alert-danger" role="alert">
                This is not a valid email.
            </div>
        );
    }
};

const vusername = (value: string) => {
    if (value.length < 3 || value.length > 20) {
        return (
            <div className="alert alert-danger" role="alert">
                The username must be between 3 and 20 characters.
            </div>
        );
    }
};

const vpassword = (value: string) => {
    if (value.length < 6 || value.length > 40) {
        return (
            <div className="alert alert-danger" role="alert">
                The password must be between 6 and 40 characters.
            </div>
        );
    }
};

const Register = () => {
    const initialRegisterState : ISignupData = {
        email: "",
        username: "",
        password: ""
    };
    const form = useRef<any>();
    const checkBtn = useRef<any>();

    const [data, setData] = useState(initialRegisterState);

    const [successful, setSuccessful] = useState(false);

    const { message } = useSelector((state: any) => state.message);
    const dispatch = useDispatch();

    const handleInputChange = (event: ChangeEvent<HTMLInputElement>) => {
        const { name, value } = event.target;
        setData({ ...data, [name]: value });
    };

    const handleRegister = (e: ChangeEvent<HTMLInputElement>) => {
        e.preventDefault();

        setSuccessful(false);

        form.current.validateAll();

        if (checkBtn.current.context._errors.length === 0) {
            // @ts-ignore
            dispatch(register(data))
                .then((res: any) => {
                    setSuccessful(true);
                })
                .catch(() => {
                    setSuccessful(false);
                });
        }
    };

    return (
        <div className="col-md-12">
            <div className="card card-container">
                <img
                    src="//ssl.gstatic.com/accounts/ui/avatar_2x.png"
                    alt="profile-img"
                    className="profile-img-card"
                />

                <Form onSubmit={handleRegister} ref={form}>
                    {!successful && (
                        <div>
                            <div className="form-group">
                                <label htmlFor="username">Username</label>
                                <Input
                                    type="text"
                                    className="form-control"
                                    name="username"
                                    value={data.username}
                                    onChange={handleInputChange}
                                    validations={[required, vusername]}
                                />
                            </div>

                            <div className="form-group">
                                <label htmlFor="email">Email</label>
                                <Input
                                    type="text"
                                    className="form-control"
                                    name="email"
                                    value={data.email}
                                    onChange={handleInputChange}
                                    validations={[required, validEmail]}
                                />
                            </div>

                            <div className="form-group">
                                <label htmlFor="password">Password</label>
                                <Input
                                    type="password"
                                    className="form-control"
                                    name="password"
                                    value={data.password}
                                    onChange={handleInputChange}
                                    validations={[required, vpassword]}
                                />
                            </div>

                            <div className="form-group">
                                <button className="btn btn-primary btn-block">Sign Up</button>
                            </div>
                        </div>
                    )}

                    {message && (
                        <div className="form-group">
                            <div className={ successful ? "alert alert-success" : "alert alert-danger" } role="alert">
                                {message}
                            </div>
                        </div>
                    )}
                    <CheckButton style={{ display: "none" }} ref={checkBtn} />
                </Form>
            </div>
        </div>
    );
};

export default Register;
