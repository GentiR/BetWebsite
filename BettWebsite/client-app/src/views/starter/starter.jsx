import React from 'react';
import {
    Row,
    Col
} from 'reactstrap';
import { SlideshowPhoto, Projects, Feeds } from 'components/dashboard-components';

const Starter = () => {
    return (
        <div>
            <Row>
                <Col sm={4} lg={8}>
                    <SlideshowPhoto />
                </Col>
                <Col sm={6} lg={4}>
                    <Feeds />
                </Col>
            </Row>
            <Row>
                <Col sm={12}>
                    <Projects />
                </Col>
            </Row>      
        </div>
    );
}

export default Starter;
