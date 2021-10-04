import React from "react";
import logo from "../../../assets/images/slideshowpohtos/stadium2.png"
//@ts-ignore
import {Card} from 'reactstrap';
import "../../../assets/scss/Slideshow.css";

const SlideshowPhoto = () => {
    return (
        <Card>
             <img src={logo} alt="Logo"/>
             <div id="centered"><h2> Welcome to "Extreme Bets" - who everyone are winners</h2></div>
        </Card>
    );
}
export default SlideshowPhoto;

