import React, {useCallback, useEffect} from 'react';
import {Routes, Route, Link, useLocation} from "react-router-dom";
import AddBook from './components/library/AddBook';
import Book from './components/library/Book';
import EditBook from './components/library/EditBook';
import Main from './components/library/Main';

import './styles/App.css';
import "bootstrap/dist/css/bootstrap.min.css";
import Signin from './components/auth/Signin';
import Signup from './components/auth/Signup';
import Profile from './components/auth/Profile';
import Navbar from "./components/navbar";
import {useDispatch, useSelector} from "react-redux";
import {clearMessage} from "./actions/message";
import {logout} from "./actions/auth";

function App() {
    const { user: currentUser } = useSelector((state: any) => state.auth);
    const dispatch = useDispatch();

    let location = useLocation();

    useEffect(() => {
        if (["/login", "/register"].includes(location.pathname)) {
            dispatch(clearMessage()); // clear message when changing location
        }
    }, [dispatch, location]);

    const logOut = useCallback(() => {
        // @ts-ignore
        dispatch(logout());
    }, [dispatch]);

  return (
      <div>
        <Navbar curentUser={currentUser} logOut={logOut}/>
        <div className="container mt-3">
          <Routes>
            <Route path="/" element={<Main/>} />
            <Route path="/books" element={<Main/>} />
            <Route path="/add" element={<AddBook/>} />
            <Route path="/books/:id" element={<Book/>} />
            <Route path="/books/:id/edit" element={<EditBook/>} />
            <Route path="/signin" element={<Signin/>} />
            <Route path="/signup" element={<Signup/>} />
            <Route path="/profile" element={<Profile/>} />
          </Routes>
        </div>
      </div>
  );
}

export default App;
