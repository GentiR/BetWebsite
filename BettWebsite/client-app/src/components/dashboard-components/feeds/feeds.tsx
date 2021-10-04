import React from "react";
//@ts-ignore
import { Card,CardBody,CardTitle} from 'reactstrap';

const Feeds = () => {
    return (
        <Card>
        <CardBody>
            <CardTitle>News</CardTitle>          
                <div className="feed-widget">
                    <ul className="list-style-none feed-body m-0 pb-3">
                        <li className="feed-item">
                            <div className="feed-icon bg-info"><i className="far fa-bell"></i></div>LIVE:Messi scores, PSG  vs. Man City<span className="ml-auto font-12 text-muted">Just Now</span>
                        </li>
                        <li className="feed-item">
                            <div className="feed-icon bg-info"><i className="far fa-bell"></i></div>Koeman takes aim at Barca as exit talk grows<span className="ml-auto font-12 text-muted">3 hours ago</span>
                        </li>
                        <li className="feed-item">
                            <div className="feed-icon bg-info"><i className="far fa-bell"></i></div>Arteta hits back at Leno in Arsenal GK row<span className="ml-auto font-12 text-muted">2 week ago</span>
                        </li>
                        <li className="feed-item">
                            <div className="feed-icon bg-info"><i className="far fa-bell"></i></div>Anfield doesn't intimidate Man City - Guardiola<span className="ml-auto font-12 text-muted">1 month ago</span>
                        </li>
                    </ul>
                </div>
        </CardBody>
        </Card>
    );
}

export default Feeds;
