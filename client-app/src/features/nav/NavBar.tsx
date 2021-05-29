import React from "react";
import { Button, Container, Menu, MenuItem } from "semantic-ui-react";

interface IProps {
    openCreateForm: () => void;
}

const NavBar: React.FC<IProps> = ({openCreateForm}) => {
    return (
        <Menu fixed='top' inverted>
            <Container>
                <MenuItem header>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: '10px'}} />
                    Reactivities
                </MenuItem>
                <Menu.Item name="Activities" />
                <Menu.Item>
                    <Button onClick={openCreateForm} positive content='Create Activity' />
                </Menu.Item>
            </Container>

        </Menu>
    );
};

export default NavBar;
