import React from 'react';
import {Link} from "react-router-dom";

const Navbar = (props: any) => {
    return (
        <nav className="navbar navbar-expand navbar-dark bg-dark">
            <a href="/tutorials" className="navbar-brand">
                LIBRARY
            </a>
            <div className="navbar-nav mr-auto">
                <li className="nav-item">
                    <Link to={"/tutorials"} className="nav-link">
                        Books
                    </Link>
                </li>
                <li className="nav-item">
                    <Link to={"/add"} className="nav-link">
                        Add book
                    </Link>
                </li>
            </div>
            {props.currentUser ? (
                <div className="navbar-nav ml-auto">
                    <li className="nav-item">
                        <Link to={"/profile"} className="nav-link">
                            {props.currentUser.userName}
                        </Link>
                    </li>
                    <li className="nav-item">
                        <a href="/login" className="nav-link" onClick={props.logOut}>
                            LogOut
                        </a>
                    </li>
                </div>
            ) : (
                <div className="d-flex navbar-nav">
                    <li className="nav-item mr-2">
                        <Link to={"/signin"} className="nav-link">
                            Sign in
                        </Link>
                    </li>
                    <li className="nav-item btn-info rounded mr-2">
                        <Link to={"/signup"} className="nav-link">
                            Sign up
                        </Link>
                    </li>
                </div>
            )}

        </nav>
    );
};

export default Navbar;